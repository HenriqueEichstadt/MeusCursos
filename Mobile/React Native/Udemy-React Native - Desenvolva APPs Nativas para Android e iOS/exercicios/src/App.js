import React from 'react';
import {SafeAreaView, StyleSheet, Text, View} from 'react-native';

import MinMax from './components/MinMax';
import CompPadrao, { Comp1, Comp2 } from './components/Multi';
import Primeiro from './components/Primeiro';
import Aleatorio from "./components/Aleatorio";
import Titulo from "./components/Titulo";
import Botao from "./components/Botao";
import Contador from "./components/Contador";
//import Pai from "./components/direta/Pai";
//import Pai from "./components/indireta/Pai";
import ContadorV2 from "./components/contador/ContadorV2";
import Diferenciar from "./components/Diferenciar";
import ParImpar from "./components/ParImpar";
import Familia from "./components/relacao/Familia";
import Membro from "./components/relacao/Membro";

export default function App() {
    return <SafeAreaView style={style.app}>

        <Familia>
            <Membro nome="Bia" sobrenome="Arruda"/>
            <Membro nome="Carlos" sobrenome="Arruda"/>
        </Familia>

        <Familia>
            <Membro nome="Ana" sobrenome="Silva"/>
            <Membro nome="Julia" sobrenome="Silva"/>
            <Membro nome="Gui" sobrenome="Silva"/>
            <Membro nome="Rebeca" sobrenome="Silva"/>
        </Familia>

        {/*
        <ParImpar num={3} />
        <Diferenciar/>
        <ContadorV2 />
        <Pai/>
        <Pai/>
        <Contador inicial={100} passo={10} />
        <Botao/>
        <Titulo principal="Cadastro produto"
                secundario="Tela de cadastro de produto"
        />
        <MinMax min={3} max={20}/>
        <MinMax min={1} max={94}/>
        <Aleatorio min={1} max={60}/>
        <CompPadrao />
        <Comp1 />
        <Comp2 />
        <Primeiro />*/}
    </SafeAreaView>
}

const style = StyleSheet.create({
    app: {
        flexGrow: 1,
        justifyContent: "center",
        alignItems: "center",
        padding: 20
    }
})
