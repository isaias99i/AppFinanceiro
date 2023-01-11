import 'package:flutter/material.dart';
import 'package:front/Tools/custom_Label.dart';


class MyHomePage extends StatefulWidget {
  const MyHomePage({super.key, required this.title, required this.name, required this.saldo});

  final String title;
  final String name;
  final double saldo;

  @override
  State<MyHomePage> createState() => _MyHomePageState();
}

class _MyHomePageState extends State<MyHomePage> {
  int _counter = 0;

  void _incrementCounter() {
    setState(() {
      _counter++;
    });
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text(widget.title),
      ),
      body: Column(
        crossAxisAlignment: CrossAxisAlignment.start,
        mainAxisAlignment: MainAxisAlignment.start,
        children: <Widget>[
          Padding(
            padding: const EdgeInsets.all(8.0),
            child: Text(
              'Bem vindo ${widget.name}',
              style: const TextStyle(fontSize: 20, fontWeight: FontWeight.bold),
            ),
          ),
          Padding(
            padding: const EdgeInsets.all(8.0),
            child: Text(
              'Seu saldo atual é R\$ ${widget.saldo.toString()}'
            ),
          ),
          Center(
            child: Padding(
              padding: const EdgeInsets.all(16.0),
              child: Expanded(
                flex: 1,
                child: Row(
                  children: const [
                    CustomLabel(lengthPadding: 6,text: 'Receita',),
                    CustomLabel(lengthPadding: 6,text: 'Despesa',),
                    CustomLabel(lengthPadding: 6,text: 'Saldo Mensal',),
                    CustomLabel(lengthPadding: 6,text: 'Segurança Ano',),
                    CustomLabel(lengthPadding: 6,text: '%',),
                    CustomLabel(lengthPadding: 6,text: 'Atual',),
                  ],
                ),
              ),
            ),
          )
        ],
      ),
    );
  }
}
