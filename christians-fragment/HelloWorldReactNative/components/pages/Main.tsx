// Main.tsx
import React from "react";
import { View, Text, StyleSheet, TouchableOpacity } from "react-native";
import { AntDesign, MaterialIcons } from "@expo/vector-icons";
import Chat from "../Chat";

const Main: React.FC = ({ navigation }: any) => {
  return (
    <View style={styles.container}>
      <View style={styles.header}>
        <TouchableOpacity
          style={styles.iconButton}
          onPress={() => navigation.navigate("Profile")} // Placeholder for profile navigation
        >
          <MaterialIcons name="account-circle" size={30} color="white" />
        </TouchableOpacity>
        <Text style={styles.headerTitle}>Chat</Text>
        <TouchableOpacity
          style={styles.iconButton}
          onPress={() => navigation.navigate("Settings")}
        >
          <AntDesign name="setting" size={30} color="white" />
        </TouchableOpacity>
      </View>
      <Chat />
    </View>
  );
};

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: "#272727",
  },
  header: {
    flexDirection: "row",
    justifyContent: "space-between",
    alignItems: "center",
    paddingHorizontal: 10,
    paddingTop: 30, // Adjusted for better visibility, depend on the device
    paddingBottom: 10,
    backgroundColor: "#0C0C0C",
  },
  headerTitle: {
    fontSize: 24,
    color: "white",
    fontWeight: "bold",
  },
  iconButton: {
    padding: 10,
  },
});

export default Main;
