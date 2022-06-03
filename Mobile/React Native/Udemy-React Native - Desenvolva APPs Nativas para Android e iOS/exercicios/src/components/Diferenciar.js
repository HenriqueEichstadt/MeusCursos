import React from 'react';
import {Platform, StyleSheet, Text, View} from 'react-native';
import Estilo from "./estilo";

export default function Diferenciar() {
    if(Platform.OS === 'android') {
        return <Text style={Estilo.txtG}>Android</Text>
    }
    else if(Platform.OS === 'ios') {
        return <Text style={Estilo.txtG}>iOS</Text>
    }
    else {
        return <Text style={Estilo.txtG}>{Platform.OS}</Text>
    }
}
