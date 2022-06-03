import React, { useState } from 'react';
import {StyleSheet, Text, View} from 'react-native';
import Estilo from "../estilo";
import ContadorDisplay from "./ContadorDisplay";
import ContadorBotoes from "./ContadorBotoes";

export default function ContadorV2() {

    const [num, setNum] = useState(0);

    const inc = () => setNum(num + 1);
    const dec = () => setNum(num - 1);

    return <>
        <Text style={Estilo.txtG}>
            Contador
        </Text>
        <ContadorDisplay num={num} />
        <ContadorBotoes inc={inc} dec={dec} />
    </>
}
