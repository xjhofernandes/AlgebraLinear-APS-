import 'package:estudos_flutter/models/contact.dart';
import 'package:sqflite/sqlite_api.dart';
import 'package:estudos_flutter/database/app_database.dart';

class ContactDAO {

  static const tableSql = 'CREATE TABLE $_tableName('
          'id INTEGER PRIMARY KEY, '
          'name TEXT, '
          'account_number INTEGER)';

  static const _tableName = 'TAB_CONTACTS';

  Future<int> save(Contact contact) async {
    final Database db = await getDataBase();
    Map<String, dynamic> contactMap = _toMap(contact);
    return db.insert(_tableName, contactMap);
  }

  Map<String, dynamic> _toMap(Contact contact) {
    final Map<String, dynamic> contactMap = Map();
    contactMap['name'] = contact.name;
    contactMap['account_number'] = contact.accountNumber;
    return contactMap;
  }

  Future<List<Contact>> findAll() async {
    final Database db = await getDataBase();
    final List<Map<String, dynamic>> result = await db.query(_tableName);
    List<Contact> contacts = _toList(result);
    return contacts;
  }

  List<Contact> _toList(List<Map<String, dynamic>> result) {
    final List<Contact> contacts = List();
    for (Map<String, dynamic> row in result) {
      final Contact contact = Contact(
        id: row['id'],
        name: row['name'],
        accountNumber: row['account_number'],
      );
      contacts.add(contact);
    }
    return contacts;
  }

}
