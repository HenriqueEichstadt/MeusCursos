import React from 'react';
import {StyleSheet, Text, View} from 'react-native';
import Estilo from "../estilo";

export default function Familia(props) {
    return <>
        <Text>[Início] Membros da Familia: </Text>
        {props.children}
        <Text>[Fim] Membros da Familia: </Text>
    </>
}
