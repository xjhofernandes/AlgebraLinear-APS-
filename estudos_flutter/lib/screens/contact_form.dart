import 'package:estudos_flutter/components/editor.dart';
import 'package:estudos_flutter/database/DAO/contact_dao.dart';
import 'package:estudos_flutter/database/app_database.dart';
import 'package:estudos_flutter/models/contact.dart';
import 'package:flutter/material.dart';

class ContactForm extends StatefulWidget {
  @override
  _ContactFormState createState() => _ContactFormState();
}

class _ContactFormState extends State<ContactForm> {
  final TextEditingController _controllerCampoNome = TextEditingController();
  final TextEditingController _controllerCampoConta = TextEditingController();
  final ContactDAO _dao = ContactDAO();

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
                  onPressed: () {
                    final String nome = _controllerCampoNome.text;
                    final int conta = int.tryParse(_controllerCampoConta.text);
                    if (nome != null && conta != null) {
                      _dao.save(Contact(name: nome, accountNumber: conta))
                          .then((id) => Navigator.pop(context));
                    }
                  },
                  color: Theme.of(context).primaryColor,
                ),
              ),
            )
          ],
        ),
      ),
    );
  }
}
