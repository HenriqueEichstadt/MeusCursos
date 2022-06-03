import React from 'react';
import {StyleSheet, Text, View} from 'react-native';
import Estilo from "./estilo";

export default function ParImpar(props) {
    return <View>
        <Text style={Estilo.txtG}>O resultado é:</Text>
        { props.num % 2 === 0
            ? <Text style={Estilo.txtG}>Par</Text>
            : <Text style={Estilo.txtG}>Ímpar</Text>
        }
    </View>
}
