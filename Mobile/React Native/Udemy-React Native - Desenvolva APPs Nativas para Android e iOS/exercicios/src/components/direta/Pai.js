import React from 'react';
import {StyleSheet, Text, View} from 'react-native';
import Estilo from "../estilo";
import Filho from "./Filho";

export default function Pai() {
    let x = 13;
    let y = 100;
    return <>
        <Filho a={x} b={y} />
        <Filho a={x + 100} b={y + 200} />
    </>
}
