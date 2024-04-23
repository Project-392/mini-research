// ProfilePicture.tsx
import React, { useState } from "react";
import { TouchableOpacity, Image, Alert, StyleSheet } from "react-native";
import * as ImagePicker from "expo-image-picker";
import { MaterialCommunityIcons } from "@expo/vector-icons";

const ProfilePicture = () => {
  const [profileImage, setProfileImage] = useState<string | null>(null);

  const pickImage = async () => {
    let mediaLibraryPermissionResponse;
    // Request permissions to access the media library
    mediaLibraryPermissionResponse =
      await ImagePicker.requestMediaLibraryPermissionsAsync();
    if (mediaLibraryPermissionResponse.status !== "granted") {
      Alert.alert(
        "Permission Required",
        "This requires access to your photo library."
      );
      return;
    }
    // Choosing an image from the gallery
    const result = await ImagePicker.launchImageLibraryAsync({
      mediaTypes: ImagePicker.MediaTypeOptions.Images,
      allowsEditing: true,
      aspect: [1, 1],
      quality: 1,
    });

    // If the operation is not canceled and an image is picked
    if (!result.canceled && result.assets) {
      setProfileImage(result.assets[0].uri);
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
          }}
        />
      ) : (
        <MaterialCommunityIcons
          name="account-circle-outline"
          size={100}
          color={"white"}
        />
      )}
    </TouchableOpacity>
  );
};

export default ProfilePicture;