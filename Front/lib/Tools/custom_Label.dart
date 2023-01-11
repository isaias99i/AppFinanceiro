import 'package:flutter/material.dart';

class CustomLabel extends StatefulWidget {
  final double lengthPadding;
  final String text;

  const CustomLabel({Key? key, required this.lengthPadding, required this.text})
      : super(key: key);

  @override
  State<CustomLabel> createState() => _CustomLabelState();
}

class _CustomLabelState extends State<CustomLabel> {
  @override
  Widget build(BuildContext context) {
    return Padding(
        padding: EdgeInsets.all(widget.lengthPadding),
        child: Text(
          widget.text,
          style: const TextStyle(
            color: Colors.black,
            backgroundColor: Colors.cyanAccent,
            fontSize: 10,
            fontWeight: FontWeight.bold
          ),
        ));
  }
}
