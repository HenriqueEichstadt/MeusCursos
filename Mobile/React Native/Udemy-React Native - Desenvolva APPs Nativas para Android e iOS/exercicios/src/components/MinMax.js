import React from 'react';
import {StyleSheet, Text, View} from 'react-native';
import Estilo from './estilo';

export default function MinMax(props) {
    return <Text style={Estilo.txtG}>O valor {props.max} é maior que o valor {props.min}!</Text>
}
