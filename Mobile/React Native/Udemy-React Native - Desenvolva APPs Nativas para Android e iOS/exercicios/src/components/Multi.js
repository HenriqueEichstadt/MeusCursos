import React from 'react';
import {Text, View} from 'react-native';
import Estilo from './estilo';

export default function Comp() {
    return <Text style={Estilo.txtG}>Comp #Oficial</Text>
}

export function Comp1() {
    return <Text style={Estilo.txtG}>Comp #01</Text>
}

export function Comp2() {
    return <Text style={Estilo.txtG}>Comp #02</Text>
}
