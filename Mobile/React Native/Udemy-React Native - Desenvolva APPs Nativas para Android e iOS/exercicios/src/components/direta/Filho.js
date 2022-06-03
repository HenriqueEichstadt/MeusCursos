import React from 'react';
import {StyleSheet, Text, View} from 'react-native';
import Estilo from "../estilo";

export default function Filho({props}) {
    return <>
        <Text style={Estilo.txtG}>{props.a}</Text>
        <Text style={Estilo.txtG}>{props.b}</Text>
    </>
}
