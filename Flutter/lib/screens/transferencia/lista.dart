import 'package:alura_project/models/transferencia.dart';
import 'package:flutter/material.dart';

import 'formulario.dart';


class ListaTransferencias extends StatefulWidget {
  final List<Transferencia> _transferencias = List();

  @override
  State<StatefulWidget> createState() {
    return ListaTransferenciasState();
  }
}

class ListaTransferenciasState extends State<ListaTransferencias> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text(
          'Trasferências',
        ),
      ),
      body: ListView.builder(
        itemCount: widget._transferencias.length,
        itemBuilder: (context, indice) {
          final transferencia = widget._transferencias[indice];
          return ItemTransferencia(transferencia);
        },
      ),
      floatingActionButton: FloatingActionButton(
        child: Icon(Icons.add),
        onPressed: () {
          final Future<Transferencia> future =
              Navigator.push(context, MaterialPageRoute(
            builder: (context) {
              return FormularioTransferencia();
            },
          ));
          future.then((transferenciaRecebida) {
            if (transferenciaRecebida != null)
              setState(() {//setState para fazer uma atualização assincrona.
              widget._transferencias.add(transferenciaRecebida);
              });
          });
        },
      ),
    );
  }
}

class ItemTransferencia extends StatelessWidget {
  final Transferencia _transferencia; //"_" Significa privado

  const ItemTransferencia(this._transferencia);
  @override
  Widget build(BuildContext context) {
    return Card(
      child: ListTile(
        leading: Icon(Icons.monetization_on),
        title: Text('Valor: ${_transferencia.valor}'),
        subtitle: Text('Conta: ${_transferencia.numeroConta}'),
        trailing: Icon(Icons.more_vert),
      ),
    );
  }
}