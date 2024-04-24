// Profile.tsx
import React, { useContext, useRef, useState } from "react";
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
import { AntDesign } from "@expo/vector-icons";
import { Modalize } from "react-native-modalize";
import GearModal from "../GearModal";
import UserContext from "../../Context/UserContext";

const Profile: React.FC = () => {
  const navigation = useNavigation();
  const [editable, setEditable] = useState<boolean>(false);

  const {
    name,
    age,
    bio,
    diet,
    medicalHistory,
    scanHistory,
    setName,
    setAge,
    setBio,
    setDiet,
    setMedicalHistory,
  } = useContext(UserContext);

  const modalizeRef = useRef<Modalize>(null);
  const toggleEdit = () => {
    setEditable(!editable);
  };

  const onOpenModal = () => {
    modalizeRef.current?.open();
  };

  const getInputStyle = (isEditable: boolean) => {
    return isEditable
      ? [styles.input, styles.editableInput] // Apply "after" styles when editable
      : {}; // Apply "before" styles when not editable
  };

  return (
    <View style={styles.container}>
      <View style={styles.header}>
        <TouchableOpacity
          style={styles.leftControls}
          onPress={() => navigation.goBack()}
        >
          <MaterialCommunityIcons name="arrow-right" size={30} color="white" />
        </TouchableOpacity>
        <Text style={styles.headerTitle}>Profile</Text>
        <View style={styles.rightControls}>
          {editable ? (
            <TouchableOpacity onPress={toggleEdit}>
              <MaterialCommunityIcons name="check" size={30} color="white" />
            </TouchableOpacity>
          ) : (
            <TouchableOpacity onPress={toggleEdit}>
              <MaterialCommunityIcons name="pencil" size={30} color="white" />
            </TouchableOpacity>
          )}
          <TouchableOpacity
            style={styles.iconButton}
            onPress={onOpenModal} // Open modal on press
          >
            <AntDesign name="setting" size={30} color="white" />
          </TouchableOpacity>
        </View>
      </View>
      <View style={styles.contentContainer}>
        <ProfilePicture />
        <View style={styles.descContainer}>
          <Text style={[styles.desc, { marginTop: 12 }, styles.headerDesc]}>
            Name
          </Text>
          <TextInput
            style={[styles.input, styles.headerText, getInputStyle(editable)]}
            value={name}
            onChangeText={setName}
            editable={editable}
          />
        </View>
        <View style={[styles.descContainer, styles.headerDescContainer]}>
          <Text style={[styles.desc, styles.headerDesc]}>Age</Text>
          <TextInput
            style={[styles.input, styles.headerText, getInputStyle(editable)]}
            value={age}
            onChangeText={setAge}
            editable={editable}
          />
        </View>
      </View>
      <ScrollView style={styles.scrollView}>
        <View style={styles.descContainer}>
          <Text style={[styles.desc, styles.bruh]}>Bio</Text>
          <TextInput
            style={[styles.input, styles.bubble, getInputStyle(editable)]}
            value={bio}
            onChangeText={setBio}
            editable={editable}
            multiline
            numberOfLines={4}
          />
        </View>
        <View style={styles.descContainer}>
          <Text style={[styles.desc, styles.bruh]}>Diet</Text>
          <TextInput
            style={[styles.input, styles.bubble, getInputStyle(editable)]}
            value={diet}
            onChangeText={setDiet}
            editable={editable}
            multiline
            numberOfLines={4}
          />
        </View>
        <View style={[styles.descContainer, { marginBottom: 100 }]}>
          <Text style={[styles.desc, styles.bruh]}>Medical History</Text>
          <TextInput
            style={[styles.input, styles.bubble, getInputStyle(editable)]}
            value={medicalHistory}
            onChangeText={setMedicalHistory}
            editable={editable}
            multiline
            numberOfLines={4}
          />
        </View>
      </ScrollView>
      <GearModal ref={modalizeRef} navigation={navigation} />
    </View>
  );
};

const styles = StyleSheet.create({
  leftControls: {
    position: "absolute",
    left: 20,
  },
  rightControls: {
    flexDirection: "row",
    alignItems: "center",
    position: "absolute",
    right: 12,
  },
  headerTitle: {
    color: "white",
    fontSize: 28,
    fontWeight: "bold",
  },
  editableInput: {
    borderWidth: 1,
    borderColor: "white",
  },
  headerText: {
    fontSize: 20,
    fontWeight: "bold",
    borderWidth: 1,
    borderColor: "#404040",
  },
  headerDesc: {
    fontSize: 18,
  },
  iconButton: {
    padding: 10,
  },
  bruh: {
    fontSize: 16,
    marginBottom: 8,
  },
  scrollView: {
    flex: 2,
    width: "100%",
    borderColor: "white",

    padding: 10,
    backgroundColor: "#261E1A",
    paddingTop: 18,
    paddingBottom: 60,

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
    flex: 0.78,
    width: "100%",
    alignItems: "center",
    paddingHorizontal: 20,
    paddingBottom: 18,
  },
  container: {
    flex: 1,
    backgroundColor: "black",
  },
  header: {
    position: "relative",
    flexDirection: "row",
    justifyContent: "center",
    alignItems: "center",
    padding: 20,
    paddingBottom: 5,
  },
  bubble: {
    height: 100,
  },
  input: {
    borderWidth: 0,
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
