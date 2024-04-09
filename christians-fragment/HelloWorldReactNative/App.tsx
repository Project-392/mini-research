import React, { useState } from "react";
import { StyleSheet, Text, View, Button, SafeAreaView } from "react-native";
import axios from "axios";
import MessagesScreen from "./components/MessageScreen";
import Chat from "./components/Chat";

export default function App() {
  const [message, setMessage] = useState("");

  const fetchMessage = async () => {
    try {
      const response = await axios.get("https://localhost:7277/HelloWorld");
      setMessage(response.data);
    } catch (error) {
      console.error(error);
    }
  };

  return (
    <SafeAreaView style={styles.container}>
      <Chat />
    </SafeAreaView>
  );
}

/**
 * <Text>{message}</Text>
 * <Button title="Fetch Message" onPress={fetchMessage}
 */

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: "#fff",
    alignItems: "center",
    justifyContent: "center",
  },
});
