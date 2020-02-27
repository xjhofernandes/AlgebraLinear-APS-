import 'package:estudos_flutter/screens/contact_form.dart';
import 'package:flutter/material.dart';

class ContactsList extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text('Contacts'),
      ),
      body: ListView(
        children: <Widget>[
          Card(
            child: ListTile(
              title: Text(
                'Nome',
                style: TextStyle(
                  fontSize: 24.0,
                ),
              ),
              subtitle: Text(
                'Número da Conta',
                style: TextStyle(
                  fontSize: 16.0,
                ),
              ),
            ),
          )
        ],
      ),
      floatingActionButton: FloatingActionButton(
        onPressed: (){
          Navigator.of(context).push(MaterialPageRoute(
            builder: (context) => ContactForm(),
          )).then((createContact) => print(createContact));
        },
        child: Icon(Icons.add),
      ),
    );
  }
}
