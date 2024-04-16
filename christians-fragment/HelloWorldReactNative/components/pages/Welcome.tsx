// Welcome.tsx
import React from "react";
import { View, Text, Button, StyleSheet, TouchableOpacity } from "react-native";
import { useNavigation } from "@react-navigation/native";

type Props = {
  navigation: any;
};

const Welcome: React.FC<Props> = ({ navigation }) => {
  return (
    <View style={styles.container}>
      <View style={styles.titleContainer}>
        <Text style={styles.title}>MyPet</Text>
      </View>
      <View style={styles.buttonContainer}>
        <TouchableOpacity
          style={[styles.buttonPress, styles.signup]}
          onPress={() => navigation.navigate("Signup")}
        >
          <Text style={[styles.buttonText, styles.signupText]}>Signup</Text>
        </TouchableOpacity>
        <TouchableOpacity
          style={styles.buttonPress}
          onPress={() => navigation.navigate("Login")}
        >
          <Text style={styles.buttonText}>Login</Text>
        </TouchableOpacity>
      </View>
    </View>
  );
};

const styles = StyleSheet.create({
  buttonContainer: {
    gap: 16,
    width: "100%",
    paddingBottom: 18,
  },
  buttonText: { fontSize: 24, color: "white", fontWeight: "500" },
  buttonPress: {
    borderWidth: 1,
    borderRadius: 10,
    borderColor: "white",
    color: "white",
    paddingHorizontal: 10,
    width: "100%",
    alignItems: "center",
    justifyContent: "center",
    paddingVertical: 12,
  },
  signupText: {
    color: "black",
  },
  signup: {
    backgroundColor: "white",
  },
  titleContainer: {
    flex: 1,
    justifyContent: "center",
  },
  container: {
    flex: 1,
    alignItems: "center",
    justifyContent: "center",
    padding: 20,

    backgroundColor: "black",
  },
  title: {
    fontSize: 48,
    marginBottom: 20,
    color: "white",
    fontWeight: "bold",
  },
});

export default Welcome;
