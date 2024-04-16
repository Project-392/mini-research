// Settings.tsx
import React from "react";
import { View, Button, StyleSheet, SafeAreaView } from "react-native";
import { useNavigation } from "@react-navigation/native";

const Settings: React.FC = ({ navigation }: any) => {
  const handleLogout = () => {
    navigation.navigate("Welcome");
  };

  return (
    <SafeAreaView style={styles.container}>
      {/* Add other settings options here */}

      {/* Logout button at the bottom */}
      <View style={styles.logoutContainer}>
        <Button title="Logout" onPress={handleLogout} />
      </View>
    </SafeAreaView>
  );
};

const styles = StyleSheet.create({
  container: {
    flex: 1,
    justifyContent: "space-between", // Ensures the button is at the bottom
  },
  logoutContainer: {
    padding: 20, // Padding for aesthetic spacing
    width: "100%", // Full width button
  },
  // Add other styles for your settings items here
});

export default Settings;
