import React from 'react';
import { NavigationContainer } from '@react-navigation/native';
import { createStackNavigator } from '@react-navigation/stack';
import Chat from './components/Chat';
import Scan from './components/Scan';

const Stack = createStackNavigator();

function App() {
    return (
         // comment out the chat line for scan component to show. working on routing.
        <NavigationContainer>
            <Stack.Navigator>
                <Stack.Screen name="Chat" component={Chat} options={{ title: 'Chat' }} />
                <Stack.Screen name="Scan" component={Scan} options={{ title: 'Barcode Scanner' }} />
            </Stack.Navigator>
        </NavigationContainer>
    );
}

export default App;
