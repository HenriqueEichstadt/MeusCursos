import React from 'react';
import {StyleSheet, Text, View} from 'react-native';
import Estilo from "../estilo";

export default function ContadorDisplay(props) {
    return <View style={css.display}>
        <Text style={[Estilo.txtG, css.displayText]}>
            {props.num}
        </Text>
    </View>
}

const css = StyleSheet.create({
    display: {
        backgroundColor: "#000",
        padding: 20,
        width: 300
    },
    displayText: {
        color: "#FFF"
    }
});
