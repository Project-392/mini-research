// Profile.tsx
import React, { useState } from "react";
import {
  View,
  Text,
  TextInput,
  StyleSheet,
  TouchableOpacity,
} from "react-native";
import { useNavigation } from "@react-navigation/native";
import ProfilePicture from "../ProfilePicture"; // Ensure this path is correct
import { MaterialCommunityIcons } from "@expo/vector-icons";

const Profile: React.FC = () => {
  const navigation = useNavigation();
  const [editable, setEditable] = useState<boolean>(false);
  const [name, setName] = useState<string>("Fido");
  const [age, setAge] = useState<string>("5");
  const [description, setDescription] = useState<string>("Friendly dog");
  const [diet, setDiet] = useState<string>("Kibble");
  const [medicalHistory, setMedicalHistory] = useState<string>(
    "Up to date on shots"
  );

  const toggleEdit = () => {
    setEditable(!editable);
  };

  return (
    <View style={styles.container}>
      <View style={styles.header}>
        {editable ? (
          <TouchableOpacity onPress={toggleEdit}>
            <MaterialCommunityIcons name="check" size={30} color="black" />
          </TouchableOpacity>
        ) : (
          <TouchableOpacity onPress={toggleEdit}>
            <MaterialCommunityIcons name="pencil" size={30} color="black" />
          </TouchableOpacity>
        )}
        <TouchableOpacity onPress={() => navigation.goBack()}>
          <MaterialCommunityIcons name="arrow-left" size={30} color="black" />
        </TouchableOpacity>
      </View>
      <ProfilePicture />
      <TextInput
        style={styles.input}
        value={name}
        onChangeText={setName}
        editable={editable}
      />
      <TextInput
        style={styles.input}
        value={age}
        onChangeText={setAge}
        editable={editable}
      />
      <TextInput
        style={styles.input}
        value={description}
        onChangeText={setDescription}
        editable={editable}
      />
      <TextInput
        style={styles.input}
        value={diet}
        onChangeText={setDiet}
        editable={editable}
      />
      <TextInput
        style={styles.input}
        value={medicalHistory}
        onChangeText={setMedicalHistory}
        editable={editable}
      />
    </View>
  );
};

const styles = StyleSheet.create({
  container: {
    flex: 1,
    padding: 20,
    backgroundColor: "#fff",
  },
  header: {
    flexDirection: "row",
    justifyContent: "space-between",
    alignItems: "center",
    marginBottom: 20,
  },
  input: {
    borderWidth: 1,
    borderColor: "#ccc",
    padding: 10,
    marginBottom: 10,
    borderRadius: 5,
  },
});

export default Profile;
