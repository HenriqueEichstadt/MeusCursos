import React from 'react';
import {StyleSheet, Text, View} from 'react-native';
import Estilo from "./estilo";

export default function Titulo(props) {
    return <>
        <Text style={Estilo.txtG}>{props.principal}</Text>
        <Text>{props.secundario}</Text>
    </>
}
