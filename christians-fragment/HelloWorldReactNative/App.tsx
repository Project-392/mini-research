import React, { useState } from "react";
import { StyleSheet, Text, View, Button } from "react-native";
import axios from "axios";

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
    <View style={styles.container}>
      <Text>{message}</Text>
      <Button title="Fetch Message" onPress={fetchMessage} />
    </View>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: "#fff",
    alignItems: "center",
    justifyContent: "center",
  },
});
