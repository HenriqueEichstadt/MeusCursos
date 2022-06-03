import React, { useState } from 'react';
import {Button, StyleSheet, Text, View} from 'react-native';

export default function Contador( {inicial, passo} ) {

    const [numero, setNumero] = useState(inicial);

    const inc = () => setNumero(numero + passo);
    const dec = () => setNumero(numero - passo);

    return <>
        <Text>{numero}</Text>
        <Button title="+" onPress={inc} />
        <Button title="-" onPress={dec} />
    </>
}

const style = StyleSheet.create({
    Contador: {
        flexGrow: 1,
        justifyContent: "center",
        alignItems: "center"
    }
})
