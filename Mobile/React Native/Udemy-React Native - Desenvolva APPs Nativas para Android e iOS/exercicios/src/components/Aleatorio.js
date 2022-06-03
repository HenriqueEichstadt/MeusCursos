import React from 'react';
import {StyleSheet, Text, View} from 'react-native';
import Estilo from "./estilo";

export default function Aleatorio( {min, max} ) {
    const delta = max - min + 1;
    const numeroAleatorio = parseInt(Math.random() * delta) + min;

    return <Text style={Estilo.txtG}>O valor aleatório é {numeroAleatorio}!</Text>
}
