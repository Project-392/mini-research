// Profile.tsx
import React, { useState } from "react";
import {
  View,
  Text,
  TextInput,
  StyleSheet,
  TouchableOpacity,
  ScrollView,
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
            <MaterialCommunityIcons name="check" size={30} color="white" />
          </TouchableOpacity>
        ) : (
          <TouchableOpacity onPress={toggleEdit}>
            <MaterialCommunityIcons name="pencil" size={30} color="white" />
          </TouchableOpacity>
        )}
        <TouchableOpacity onPress={() => navigation.goBack()}>
          <MaterialCommunityIcons name="arrow-left" size={30} color="white" />
        </TouchableOpacity>
      </View>
      <View style={styles.contentContainer}>
        <ProfilePicture />
        <View style={styles.descContainer}>
          <Text style={[styles.desc, { marginTop: 16 }]}>Name</Text>
          <TextInput
            style={styles.input}
            value={name}
            onChangeText={setName}
            editable={editable}
          />
        </View>
        <View style={styles.descContainer}>
          <Text style={styles.desc}>Age</Text>
          <TextInput
            style={styles.input}
            value={age}
            onChangeText={setAge}
            editable={editable}
          />
        </View>

        <ScrollView style={styles.scrollView}>
          <View style={styles.descContainer}>
            <Text style={[styles.desc, styles.bruh]}>Bio</Text>
            <TextInput
              style={styles.input}
              value={description}
              onChangeText={setDescription}
              editable={editable}
              multiline
              numberOfLines={4}
            />
          </View>
          <View style={styles.descContainer}>
            <Text style={[styles.desc, styles.bruh]}>Diet</Text>
            <TextInput
              style={styles.input}
              value={diet}
              onChangeText={setDiet}
              editable={editable}
              multiline
              numberOfLines={4}
            />
          </View>
          <View style={styles.descContainer}>
            <Text style={[styles.desc, styles.bruh]}>Medical History</Text>
            <TextInput
              style={styles.input}
              value={medicalHistory}
              onChangeText={setMedicalHistory}
              editable={editable}
              multiline
              numberOfLines={4}
            />
          </View>
        </ScrollView>
      </View>
    </View>
  );
};

const styles = StyleSheet.create({
  bruh: {
    fontSize: 16,
  },
  scrollView: {
    flex: 1,
    width: "100%",
    borderColor: "white",
    borderWidth: 1,
    padding: 10,
    backgroundColor: "#181818",
    paddingTop: 16,
    marginTop: 12,
  },

  descContainer: { width: "100%" },
  desc: {
    color: "white",
    fontSize: 18,
    marginBottom: 4,
    fontWeight: "500",
  },
  contentContainer: {
    flex: 1,
    width: "100%",
    alignItems: "center",
  },
  container: {
    flex: 1,
    padding: 20,
    backgroundColor: "black",
  },
  header: {
    flexDirection: "row",
    justifyContent: "space-between",
    alignItems: "center",
    marginBottom: 20,
  },
  input: {
    borderWidth: 1,
    borderColor: "white",
    padding: 10,
    marginBottom: 10,
    borderRadius: 5,
    color: "white",
    backgroundColor: "black",
    fontSize: 18,
  },
});

export default Profile;
