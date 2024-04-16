import React, { useState } from "react";
import { StyleSheet, Text, View, Button, SafeAreaView } from "react-native";
import axios from "axios";
import Router from "./components/Router";
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

  return <Router />;
}

/**
 * <Text>{message}</Text>
 * <Button title="Fetch Message" onPress={fetchMessage}
 */
