import 'package:flutter/material.dart';

class Editor extends StatelessWidget {
  final TextEditingController controller;
  final String label;
  final String hint;
  final TextInputType tipoInput;

  Editor({this.controller, this.label, this.hint, this.tipoInput});

  @override
  Widget build(BuildContext context) {
    return Padding(
      padding: const EdgeInsets.all(16.0),
      child: TextField(
        controller: controller,
        style: TextStyle(
          fontSize: 24.0,
        ),
        decoration: InputDecoration(
          labelText: label,
          hintText: hint,
        ),
        keyboardType: tipoInput,
      ),
    );
  }
}
