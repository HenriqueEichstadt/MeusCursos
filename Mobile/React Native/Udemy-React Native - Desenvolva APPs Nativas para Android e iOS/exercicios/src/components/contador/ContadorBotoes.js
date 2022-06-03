import React from 'react';
import {Button, StyleSheet, Text, View} from 'react-native';

export default function ContadorBotoes(props) {
    return <View style={css.botoes}>
        <Button title="+" onPress={props.inc} />
        <Button title="-" onPress={props.dec} />
    </View>

}

const css = StyleSheet.create({
    botoes: {
        flexDirection: "row"
    }
});
