export type Message = {
    id: number;
    text: string;
    sender: "user" | "other";
  };