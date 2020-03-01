import 'package:path/path.dart';
import 'package:sqflite/sqflite.dart';

import 'DAO/contact_dao.dart';

Future<Database> getDataBase() async {
  final String path = join(await getDatabasesPath(), 'bitybank.db');
  return openDatabase(
    path,
    onCreate: (db, version) {
      db.execute(ContactDAO.tableSql);
    },
    version: 1,
  );
}
