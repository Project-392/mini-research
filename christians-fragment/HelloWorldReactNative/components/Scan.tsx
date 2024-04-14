import React, { useState } from 'react';
import { StyleSheet, Text, View, Button, TextInput, ScrollView, ActivityIndicator, Linking } from 'react-native';
import axios from 'axios';

// Define an interface for the offer to ensure type safety
interface Offer {
    name: string;
    price: string;
    reviewRating?: string;
    reviewCount?: string;
    link: string;
}

// Define the props interface if needed, for now, it's empty as no props are passed
interface ScanProps { }


const Scan: React.FC<ScanProps> = () => {
    const [barcode, setBarcode] = useState<string>('');
    const [results, setResults] = useState<Offer[]>([]);
    const [loading, setLoading] = useState<boolean>(false);

    const fetchAmazonOffers = async () => {
        if (!barcode) {
            console.error("Barcode is empty.");
            setLoading(false);
            return;
        }
        setLoading(true);
        try {
            const response = await axios.post('https://localhost:7277/Scan', { barcode : barcode }, {
                headers: {
                    'Content-Type': 'application/json'  // Ensure this is set to application/json
                }
            });
            setResults(response.data); // Assuming the response data is correctly typed as an array of Offer
            console.log(response.data);
        } catch (error) {
            console.error(error);
            setResults([]); // Reset results on error
        }
        setLoading(false);
    };

    return (
        <ScrollView style={styles.container}>
            <TextInput
                style={styles.input}
                onChangeText={setBarcode}
                value={barcode}
                placeholder="Enter product barcode"
                keyboardType="numeric"
            />
            <Button title="Fetch Amazon Offers" onPress={fetchAmazonOffers} disabled={loading} />
            {loading ? (
                <ActivityIndicator size="large" color="#0000ff" />
            ) : results.length > 0 ? (
                results.map((item, index) => (
                    <View key={index} style={styles.resultItem}>
                        <Text>Name: {item.name}</Text>
                        <Text>Price: {item.price}</Text>
                        <Text>Rating: {item.reviewRating || "Not available"}</Text>
                        <Text>Reviews: {item.reviewCount || "Not available"}</Text>
                        <Text style={styles.linkText} onPress={() => Linking.openURL(item.link)}>Amazon</Text>
                    </View>
                ))
            ) : (
                <Text style={styles.noResultsText}>No results found or waiting for input.</Text>
            )}
        </ScrollView>
    );
}

const styles = StyleSheet.create({
    container: {
        flex: 1,
        backgroundColor: '#fff',
        padding: 20,
    },
    input: {
        width: '100%',
        borderColor: 'gray',
        borderWidth: 1,
        padding: 10,
        marginBottom: 20,
    },
    resultItem: {
        marginTop: 10,
        padding: 10,
        borderWidth: 1,
        borderColor: 'gray',
        marginBottom: 10,
    },
    noResultsText: {
        textAlign: 'center',
    },
    linkText: {
        color: 'blue',
        textDecorationLine: 'underline'
    }
});

export default Scan;
