# BandEquipmentOCP
A simple project for calculating band member expenses using OCP

This is a little project to practice Open Closed Principle design pattern. The take away from the current status is that the Musician model is OPEN for extension (through a different instrument inheriting from it) but CLOSED for modification in that no large scale modifications are required if another instrument is added to the band. 
