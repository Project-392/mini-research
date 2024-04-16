// ProfilePicture.tsx
import React, { useState } from "react";
import { TouchableOpacity, Image, Alert } from "react-native";
import * as ImagePicker from "expo-image-picker";
import { MaterialCommunityIcons } from "@expo/vector-icons";

const ProfilePicture = () => {
  const [profileImage, setProfileImage] = useState<string | null>(null);

  const pickImage = async () => {
    const permissionResult =
      await ImagePicker.requestMediaLibraryPermissionsAsync();

    if (permissionResult.status !== "granted") {
      Alert.alert(
        "Permission Required",
        "Permission to access camera roll is required!"
      );
      return;
    }

    const result = await ImagePicker.launchImageLibraryAsync({
      mediaTypes: ImagePicker.MediaTypeOptions.Images,
      allowsEditing: true,
      aspect: [1, 1],
      quality: 1,
    });

    if (!result.cancelled) {
      setProfileImage(result.uri);
    }
  };

  return (
    <TouchableOpacity onPress={pickImage}>
      {profileImage ? (
        <Image
          source={{ uri: profileImage }}
          style={{
            width: 100,
            height: 100,
            borderRadius: 50,
            borderWidth: 1,
            borderColor: "#ccc",
          }}
        />
      ) : (
        <MaterialCommunityIcons
          name="account-circle-outline"
          size={100}
          color="#ccc"
        />
      )}
    </TouchableOpacity>
  );
};

export default ProfilePicture;
