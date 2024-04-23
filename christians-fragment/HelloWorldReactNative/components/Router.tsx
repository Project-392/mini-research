import React from "react";
import {
  createStackNavigator,
  CardStyleInterpolators,
} from "@react-navigation/stack";
import { StyleSheet, SafeAreaView, Platform } from "react-native";
import { NavigationContainer } from "@react-navigation/native";
import Welcome from "./pages/Welcome";
import Login from "./pages/Login";
import Signup from "./pages/Signup";
import Main from "./pages/Main";
import Profile from "./pages/Profile";
import Settings from "./pages/Settings";
import History from "./pages/History";

const { Navigator, Screen } = createStackNavigator();

const AppStack = () => {
  return (
    <SafeAreaView style={styles.droidSafeArea}>
      <Navigator
        initialRouteName="Welcome"
        screenOptions={{
          cardStyle: { flex: 1, backgroundColor: "transparent" },
          headerShown: false,
          presentation: "card",
        }}
      >
        <Screen name="Welcome" component={Welcome} />
        <Screen name="Signup" component={Signup} />
        <Screen name="Login" component={Login} />
        <Screen name="History" component={History} />
        <Screen name="Main" component={Main} />
        <Screen
          name="Profile"
          component={Profile}
          options={{
            cardStyleInterpolator: CardStyleInterpolators.forHorizontalIOS,
            gestureDirection: "horizontal-inverted", // Ensures gesture matches the animation
          }}
        />
        <Screen name="Settings" component={Settings} />
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
  droidSafeArea: {
    backgroundColor: "#0C0C0C",
    flex: 1,
    paddingTop: Platform.OS === "android" ? 25 : 0,
  },
});
