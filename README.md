# Luhn Algorithm

Personal School Project for C# Language (Console App)

## Problem (**Original**: Thai)
ปัจจุบันการทำธุรกรรมบนอินเทอร์เน็ตได้เข้ามาเป็นส่วนหนึ่งในชีวิตประจำวัน ซึ่งส่วนใหญ่จะมีการจ่ายผ่านบัตรเครดิต ในฐานะของโปรแกรมเมอร์อันดับหนึ่งอย่างตัวเรา จึงอยากที่จะเขียนโปรแกรมตรวจสอบบัตรเครดิตว่าหมายเลขนั้นมีอยู่จริงหรือไม่ ตามอัลกอริทึมของ Luhn ซึ่งมีขั้นตอนดังนี้:
-	ทำการรับหมายเลขบัตรเครดิตจำนวน 16 หลัก เข้ามาในรูปแบบ _xxxx-xxxx-xxxx-xxxx_
-	การทำกลับหมายเลขบัตรเครดิตจากขวาไปซ้าย และลบเครื่องหมาย `-` ออกจากข้อมูล
-	ทำการคูณตัวเลขในหลักที่เป็นเลข **คู่** ด้วยสอง
-	หากผลลัพธ์จากการคูณด้วยสองและมีค่าเกินสิบ ให้แยกเลขนั้นออกเป็นสองหลัก
-	ทำการหาผลรวมของตัวเลขทั้งหมดที่ได้คำนวณข้างต้น
-	นำผลลัพธ์ที่ได้ไป mod ด้วย 10 หากลงตัวแสดงว่าบัตรนี้มีอยู่จริง

## ขั้นตอนทางเลือก (**สั้นกว่าและลบขั้นตอนที่ไม่จำเป็นออก**)
- **ไม่ต้อง** กลับเลขเป็นขวาไปซ้าย
- ทำการคูณตัวเลขในหลัก **คี่** ด้วยสอง

## Problem (English)
Nowadays, transactions on the internet have become part of our daily lives. Most of which are paid via credit card. As our number one programmer So I want to write a program to check the credit card that the number actually exists or not. According to Luhn's algorithm, the steps are as follows:
- Receive a 16-digit credit card number into the form of _xxxx-xxxx-xxxx-xxxx_
- Reversing credit card numbers from right to left and remove the `-` from the data
- Multiply numbers in even digits with two
- If the result of multiplying by two exceeds ten, separate that number into two digits.
- Find the sum of all the numbers calculated above.
- Bring the result to the mod with 10. If it fits, then this card exists.

## Alternatives Solution (**Shorter and Removed Unnecessary Step(s)**)
- **DO NOT** have to do reverse credit card numbers from right to left.
- Multiply numbers in **odd** digits with two

## Author

👤 **Theerawat Patthawee**

* Github: [@ttwrpz](https://github.com/ttwrpz)
