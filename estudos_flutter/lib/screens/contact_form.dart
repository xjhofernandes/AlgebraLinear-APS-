import 'package:estudos_flutter/components/editor.dart';
import 'package:estudos_flutter/models/contacts.dart';
import 'package:flutter/material.dart';

class ContactForm extends StatefulWidget {

  @override
  _ContactFormState createState() => _ContactFormState();
}

class _ContactFormState extends State<ContactForm> {
  final TextEditingController _controllerCampoNome = TextEditingController();

  final TextEditingController _controllerCampoConta = TextEditingController();

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text('New contact'),
      ),
      body: SingleChildScrollView(
        child: Column(
          children: <Widget>[
            Editor(
              label: 'Full name',
              controller: _controllerCampoNome,
              tipoInput: TextInputType.text,
            ),
            Editor(
              label: 'Account number',
              controller: _controllerCampoConta,
              tipoInput: TextInputType.numberWithOptions(decimal: true),
              hint: '0000',
            ),
            Padding(
              padding: const EdgeInsets.all(8.0),
              child: SizedBox(
                width: double.maxFinite,
                child: RaisedButton(
                  child: Text('Create'),
                  onPressed: () => createContact(context),
                  color: Theme.of(context).primaryColor,
                ),
              ),
            )
          ],
        ),
      ),
    );
  }

  void createContact(BuildContext context) {
    final String nome = _controllerCampoNome.text;
    final int conta = int.parse(_controllerCampoConta.text);
    if (nome != null && conta != null){
      final contactCreate = Contacts(nome, conta);
      Navigator.pop(context, contactCreate);
    }
  }
}
