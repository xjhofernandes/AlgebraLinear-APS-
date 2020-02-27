class Contacts {
  final String name;
  final int accountNumber;

  Contacts(this.name, this.accountNumber);

  @override
  String toString() {
    return 'Nome: $name e número da conta: $accountNumber';
  }
}