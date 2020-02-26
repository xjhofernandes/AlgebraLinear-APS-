import 'package:alura_project/components/editor.dart';
import 'package:alura_project/models/transferencia.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';


class FormularioTransferencia extends StatefulWidget {

  @override
  State<StatefulWidget> createState() {
    return FormularioTransferenciaState();
  }
}

class FormularioTransferenciaState extends State<FormularioTransferencia> {
  final TextEditingController _controllerCampoNumeroConta =
      TextEditingController();
  final TextEditingController _controllerCampoValor = TextEditingController();

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text('Criando trânsferencia'),
      ),
      body: SingleChildScrollView(
        child: Column(
          children: <Widget>[
            Editor(
              controller: _controllerCampoNumeroConta,
              label: 'Número da conta',
              hint: '0000',
            ),
            Editor(
                controller: _controllerCampoValor,
                label: 'Valor',
                hint: '0.00',
                iconData: Icons.monetization_on),
            RaisedButton(
              child: Text(
                'Confirmar',
                style: TextStyle(color: Colors.white),
              ),
              onPressed: () => _criaTransferencia(context),
              color: Colors.black,
            ),
          ],
        ),
      ),
    );
  }

  void _criaTransferencia(BuildContext context) {
    final String numeroConta = _controllerCampoNumeroConta.text;
    final double valorConta = double.tryParse(_controllerCampoValor.text);
    if (numeroConta != null && valorConta != null) {
      final transferenciaCriada = Transferencia(valorConta, numeroConta);
      Navigator.pop(context, transferenciaCriada);
    }
  }
}
