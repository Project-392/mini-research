import React, { useState, useRef, useEffect } from "react";
import {
  StyleSheet,
  View,
  FlatList,
  TextInput,
  Button,
  KeyboardAvoidingView,
  Platform,
  Text,
  ListRenderItemInfo,
  TouchableOpacity,
  Animated,
} from "react-native";
import { AntDesign } from "@expo/vector-icons";
import axios from "axios";

type Message = {
  id: number;
  text: string;
  sender: "user" | "other";
};

// const dummyResponses: string[] = [
//   "Hello there!",
//   "How are you?",
//   "That's interesting, tell me more.",
//   "I'm not sure about that.",
//   "Goodbye!",
// ];

const fetchMessage = async (text: string) => {
  try {
    const response = await axios.post("https://localhost:7277/HelloWorld", {
      text: text, // This is the text you want to send to the backend
    });
    return response.data;
  } catch (error) {
    console.error(error);
  }
};

const Chat: React.FC = () => {
  const [messages, setMessages] = useState<Message[]>([]);
  const [inputText, setInputText] = useState<string>("");
  const flatListRef = useRef<FlatList<Message>>(null);

  // Define the animated value outside of the useEffect
  const scaleAnim = useRef(new Animated.Value(1)).current;

  // Function to start the pulsing animation
  const startPulsing = () => {
    scaleAnim.setValue(1); // Reset the scale to start the animation from beginning
    Animated.loop(
      Animated.sequence([
        Animated.timing(scaleAnim, {
          toValue: 1.5,
          duration: 500,
          useNativeDriver: true,
        }),
        Animated.timing(scaleAnim, {
          toValue: 1,
          duration: 500,
          useNativeDriver: true,
        }),
      ]),
      {
        iterations: -1, // Loop indefinitely
      }
    ).start();
  };

  const sendMessage = async (): Promise<void> => {
    startPulsing();
    const newMessage: Message = {
      id: Date.now(),
      text: inputText,
      sender: "user",
    };
    setMessages((prevMessages) => [...prevMessages, newMessage]);

    // Clear input field
    setInputText("");

    const replyText = await fetchMessage(inputText);

    const reply: Message = {
      id: Date.now(),
      text: replyText,
      sender: "other",
    };

    // Add reply to messages
    setMessages((prevMessages) => [...prevMessages, reply]);

    // Scroll to the bottom
    flatListRef.current?.scrollToEnd({ animated: true });
    scaleAnim.stopAnimation();

    // Trigger a spring animation upon message receipt
    Animated.spring(scaleAnim, {
      toValue: 1, // Animate back to the original scale
      friction: 3, // Make it a bit bouncy
      useNativeDriver: true,
    }).start();
  };

  const renderItem = ({ item }: ListRenderItemInfo<Message>) => (
    <View
      style={[
        styles.messageContainer,
        item.sender === "user" ? styles.userContainer : styles.otherContainer,
      ]}
    >
      <Text
        style={
          item.sender === "user" ? styles.userMessage : styles.otherMessage
        }
      >
        {item.text}
      </Text>
    </View>
  );

  return (
    <View style={styles.container}>
      <View style={styles.header}>
        <View style={{ flexDirection: "row", alignItems: "center" }}>
          <View style={styles.pfp}>
            <Animated.View
              style={[
                styles.pfpDot,
                {
                  transform: [{ scale: scaleAnim }], // Bind the animated value to the scale transform
                },
              ]}
            />
          </View>
          <Text style={styles.headerName}>Dr. Mittens</Text>
        </View>
        <View style={styles.statusContainer}>
          <View style={styles.status}></View>
          <Text style={styles.statusText}>Online</Text>
        </View>
      </View>
      <View style={styles.listContainer}>
        <FlatList
          ref={flatListRef}
          data={messages}
          renderItem={renderItem}
          keyExtractor={(item) => item.id.toString()}
        />
      </View>
      <KeyboardAvoidingView
        behavior={Platform.OS === "ios" ? "padding" : "height"}
        style={styles.inputContainer}
      >
        <View style={styles.sendContainer}>
          <TextInput
            style={styles.input}
            value={inputText}
            onChangeText={setInputText}
            placeholder="Type a message..."
          />
          <TouchableOpacity style={styles.sendButton} onPress={sendMessage}>
            <AntDesign name="rightcircle" size={35} color="#E9E9E9" />
          </TouchableOpacity>
        </View>
      </KeyboardAvoidingView>
    </View>
  );
};

const styles = StyleSheet.create({
  statusContainer: {
    flexDirection: "row",
    marginRight: 10,
    marginTop: 15,
  },
  statusText: {
    color: "white",
    marginLeft: 6,
    fontSize: 10,
    marginTop: 3,
  },
  status: {
    width: 16,
    height: 16,
    backgroundColor: "#93F071",
    borderRadius: 50,
  },
  headerName: {
    color: "white",
    marginLeft: 10,
    fontSize: 20,
    fontWeight: "bold",
  },
  pfp: {
    backgroundColor: "#272727",
    width: 50,
    height: 50,
    borderRadius: 20,
    alignItems: "center",
    justifyContent: "center",
  },
  pfpDot: {
    backgroundColor: "white",
    width: 20,
    height: 20,
    borderRadius: 50,
  },
  header: {
    paddingHorizontal: 12,
    alignItems: "center",
    justifyContent: "space-between",
    flexDirection: "row",
    backgroundColor: "#0C0C0C",
    height: 76,
    borderRadius: 20,
    marginHorizontal: 10,
    marginTop: 25,
    marginBottom: 20,
  },
  listContainer: { flex: 8, paddingHorizontal: 10 },
  sendButton: {
    justifyContent: "center",
    alignItems: "center",
    height: 50,
  },
  sendContainer: {
    flexDirection: "row",
    width: "100%",
    alignContent: "center",
    justifyContent: "center",
  },
  container: {
    flex: 1,
    backgroundColor: "#272727",
    width: "100%",
  },
  inputContainer: {
    flexDirection: "row",
    paddingHorizontal: 10,
    paddingVertical: 5,
    flex: 1,
  },
  input: {
    flex: 1,
    marginRight: 8,
    paddingHorizontal: 10,
    borderRadius: 20,
    height: 50,
    backgroundColor: "white",
    marginBottom: 10,
  },
  messageContainer: {
    padding: 10,
    borderRadius: 20,
    marginVertical: 5,
    maxWidth: "80%", // Set a max-width for the message bubbles
  },
  userContainer: {
    alignSelf: "flex-end",
    backgroundColor: "#DCF8C5", // Light green color for the user message
  },
  otherContainer: {
    alignSelf: "flex-start",
    backgroundColor: "#E5E5EA", // Light grey color for the other message
  },
  userMessage: {
    color: "black",
  },
  otherMessage: {
    color: "black",
  },
});

export default Chat;
