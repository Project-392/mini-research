import React, {
  PropsWithChildren,
  useState,
  createContext,
  Dispatch,
  SetStateAction,
} from "react";
import { Message } from "./types";

/**
 * 
name: string, 
age: string,
bio: string,
diet: string,
medicalHistory: string
scanHistory: string[]
 */

export interface UserContextType {
  name: string;
  setName: Dispatch<SetStateAction<string>>;

  age: string;
  setAge: Dispatch<SetStateAction<string>>;

  breed: string;
  setBreed: Dispatch<SetStateAction<string>>;

  bio: string;
  setBio: Dispatch<SetStateAction<string>>;

  diet: string;
  setDiet: Dispatch<SetStateAction<string>>;

  medicalHistory: string;
  setMedicalHistory: Dispatch<SetStateAction<string>>;

  profileImage: string;
  setProfileImage: Dispatch<SetStateAction<string>>;

  scanHistory: Message[];
  setScanHistory: Dispatch<SetStateAction<Message[]>>;

  messageHistory: Message[];
  setMessageHistory: Dispatch<SetStateAction<Message[] | null>>;
}

const defaultState: UserContextType = {
  name: "",
  age: "",
  breed: "",
  bio: "",
  diet: "",
  medicalHistory: "",
  profileImage: "",
  scanHistory: [],
  messageHistory: [],
  setName: () => {},
  setAge: () => {},
  setBreed: () => {},
  setBio: () => {},
  setDiet: () => {},
  setProfileImage: () => {},
  setMedicalHistory: () => {},
  setScanHistory: () => {},
  setMessageHistory: () => {},
};

const UserContext = React.createContext<UserContextType>(defaultState);

export const UserProvider: React.FC<PropsWithChildren<{}>> = ({
  children,
}: any) => {
  const [name, setName] = useState<string>("");
  const [age, setAge] = useState<string>("");
  const [breed, setBreed] = useState<string>("");
  const [bio, setBio] = useState<string>("");
  const [diet, setDiet] = useState<string>("");
  const [medicalHistory, setMedicalHistory] = useState<string>("");
  const [profileImage, setProfileImage] = useState<string>("");
  const [scanHistory, setScanHistory] = useState<Message[]>([]);
  const [messageHistory, setMessageHistory] = useState<Message[]>([]);

  return (
    <UserContext.Provider
      value={{
        name,
        age,
        breed,
        bio,
        diet,
        medicalHistory,
        profileImage,
        scanHistory,
        messageHistory,
        setName,
        setAge,
        setBreed,
        setBio,
        setDiet,
        setMedicalHistory,
        setProfileImage,
        setScanHistory,
        setMessageHistory,
      }}
    >
      {children}
    </UserContext.Provider>
  );
};

export default UserContext;
