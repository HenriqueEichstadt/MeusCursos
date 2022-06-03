import React from 'react';
import {StyleSheet, Text, View} from 'react-native';
import Estilo from "../estilo";

export default function Membro(props) {
    return <Text style={Estilo.txtG}>
        {props.nome} {props.sobrenome}
    </Text>
}
