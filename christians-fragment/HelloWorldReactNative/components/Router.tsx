// _layout.tsx
import React from "react";
import { createStackNavigator } from "@react-navigation/stack";
import { Text, StyleSheet, SafeAreaView, Platform } from "react-native";
import { NavigationContainer } from "@react-navigation/native";
import Chat from "./Chat";
import Welcome from "./pages/Welcome";
import Login from "./pages/Login";
import Signup from "./pages/Signup";
import Main from "./pages/Main";
import Profile from "./pages/Profile";
import Settings from "./pages/Settings";

const { Navigator, Screen } = createStackNavigator();

const AppStack = () => {
  const options = {
    headerShown: false,
    presentation:
      Platform.OS === "ios" ? ("card" as const) : ("modal" as const),
  };

  return (
    <SafeAreaView style={styles.droidSafeArea}>
      <Navigator
        screenOptions={{
          cardStyle: { flex: 1, backgroundColor: "transparent" },
        }}
        initialRouteName="Login"
      >
        <Screen name="Welcome" component={Welcome} options={options} />
        <Screen name="Signup" component={Signup} options={options} />
        <Screen name="Login" component={Login} options={options} />
        <Screen name="Main" component={Main} options={options} />
        <Screen name="Profile" component={Profile} options={options} />
        <Screen name="Settings" component={Settings} options={options} />
        {/* Add other screens here */}
      </Navigator>
    </SafeAreaView>
  );
};

export default function Router() {
  return (
    <NavigationContainer>
      <AppStack />
    </NavigationContainer>
  );
}

const styles = StyleSheet.create({
  headerContainer: {
    width: "100%",
    alignItems: "center",
    justifyContent: "center",
    backgroundColor: "transparent",
  },
  headerTitle: {
    fontFamily: "GeneralSans-Bold",
    fontSize: 30,
    paddingTop: 20,
    paddingBottom: 30,
    color: "black",
    fontWeight: "bold",
    backgroundColor: "transparent",
  },
  droidSafeArea: {
    flex: 1,
    paddingTop: Platform.OS === "android" ? 25 : 0,
  },
});
