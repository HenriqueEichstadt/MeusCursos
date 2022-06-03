import React, {useState} from 'react';
import {StyleSheet, Text, View} from 'react-native';
import Estilo from "../estilo";
import Filho from "./Filho";

export default function Pai() {

    const [texto, setTexto] = useState('');
    const [num, setNum] = useState(0);

    function exibirValor(numero, texto) {
        setNum(numero);
        setTexto(texto);
    }

    return <>
        <Text style={Estilo.txtG}>
            {texto}: {num}
        </Text>
        <Filho
            min={1}
            max={60}
            funcao={exibirValor}
        />
    </>
}
