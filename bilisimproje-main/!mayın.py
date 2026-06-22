import ast
import os
import PySimpleGUI as sg
from PyQt6.QtWidgets import *
import additem
import basket
import BuyMenu
import CardInfo
import edit
import List
import login
import loginsignin
import signin
import MainMenu
import UserMainMenu
import sys
import json
import pandas as pd
try:
    from IPython.display import display
except:
    os.system('pip install IPython')
    from IPython.display import display

available_products = {1001: {"name": "avocado", "price": 230,
                             "category": "grocery",
                             "quantity": 10, "date": "10/03/2021"},
                      1002: {"name": "lotion", "price": 250,
                             "category": "beauty & personal",
                             "quantity": 100,
                             "date": "15/07/2021"},
                      1003: {"name": "pain reliever", "price": 500,
                             "category": "health",
                             "quantity": 200, "date": "12/04/2021"},
                      1004: {"name": "dry pasta", "price": 20,
                             "category": "grocery",
                             "quantity": 50, "date": "27/06/2021"},
                      1005: {"name": "toothbrush", "price": 700,
                             "category": "beauty & personal",
                             "quantity": 100,
                             "date": "30/01/2021"},
                      1006: {"name": "halloween candy", "price": 33,
                             "category": "grocery",
                             "quantity": 56, "date": "22/02/2021"},
                      1007: {"name": "mascara", "price": 765,
                             "category": "beauty & personal",
                             "quantity": 70,
                             "date": "11/03/2021"},
                      1008: {"name": "capsicum", "price": 764,
                             "category": "grocery",
                             "quantity": 90, "date": "16/02/2021"},
                      1009: {"name": "blush", "price": 87,
                             "category": "beauty & personal",
                             "quantity": 50, "date": "17/07/2021"},
                      1010: {"name": "granola bars", "price": 24,
                             "category": "grocery", "quantity": 60,
                             "date": "20/05/2021"},
                      }
js = json.dumps(available_products)
fd = open("data.json", 'w')
fd.write(js)
fd.close()
def display_data():
    fd = open("data.json", 'r')
    txt = fd.read()
    data = json.loads(txt)
    print(data)
    fd.close()
    n = int(input())
    if (n == 1):
        table = pd.DataFrame(
            columns=['ID', 'name', 'price', 'category', 'quantity', 'date'])
        for i in data.keys():
            temp = pd.DataFrame(columns=['ID'])
            temp['ID'] = [i]
            for j in data[i].keys():
                temp[j] = [data[i][j]]
            table = table.append(temp)
        table = table.reset_index(drop=True)
        '''This will reset index of dataframe'''
        display(table)
        return table
    elif (n == 0):
        table = pd.DataFrame(
            columns=['ID', 'name', 'price', 'category',
                     'quantity', 'date'])
        cat = []
        for i in data.keys():
            temp = pd.DataFrame(columns=['ID'])
            temp['ID'] = [i]
            for j in data[i].keys():
                temp[j] = [data[i][j]]
                if (j == 'category'):
                    cat.append(data[i][j])
            table = table.append(temp)
            table = table.reset_index(drop=True)
            cat = set(cat)
            cat = list(cat)
        for k in cat:
            temp = pd.DataFrame()
            temp = table[table['category'] == k]
            print("Data Of Products Of Category " + k + " is:- ")
            display(temp)
            return table
    else:
        return "got mogused lol"
class anamenu(QMainWindow, loginsignin.Ui_Widget):

    def __init__(self):
        super(anamenu, self).__init__()

        self.setupUi(self)

        self.pushButton.clicked.connect(self.signin)
        self.pushButton_2.clicked.connect(self.login)



    def login(self):
        loginWindow = login()
        widget.addWidget(loginWindow)
        widget.setCurrentIndex(widget.currentIndex()+1)

    def signin(self):
        signinWindow = signin()
        widget.addWidget(signinWindow)
        widget.setCurrentIndex(widget.currentIndex()+1)





class login(QMainWindow, login.Ui_Widget):

    def amogus(self):
        if self.girissifre.text() == "admin123" and self.girismaili.text() == "admin":
            adminmenu = admin()
            widget.addWidget(adminmenu)
            widget.setCurrentIndex(widget.currentIndex() + 1)
        else:
            usermenu = user()
            widget.addWidget(usermenu)
            widget.setCurrentIndex(widget.currentIndex() + 1)


    def __init__(self):

        super(login, self).__init__()

        self.setupUi(self)

        self.loginbutton.clicked.connect(self.amogus)




class admin(QMainWindow, MainMenu.Ui_Widget):

    def logoff(self):
        zamn = anamenu()
        widget.addWidget(zamn)
        widget.setCurrentIndex(widget.currentIndex() + 1)

    def additems(self):
        itemaddingmenu = additem()
        widget.addWidget(itemaddingmenu)
        widget.setCurrentIndex(widget.currentIndex() + 1)

    def selectitem(self):
        itemselectingmenu = List()
        widget.addWidget(itemselectingmenu)
        widget.setCurrentIndex(widget.currentIndex() + 1)

    def __init__(self):

        super(admin, self).__init__()

        self.setupUi(self)

        self.pushButton_3.clicked.connect(self.additems)

        self.pushButton_4.clicked.connect(self.selectitem)

        self.pushButton_6.clicked.connect(self.logoff)

class user(QMainWindow, UserMainMenu.Ui_Widget):

    def buy(self):

        buymenu = buy()
        widget.addWidget(buymenu)
        widget.setCurrentIndex(widget.currentIndex() + 1)

    def basketuifunc(self):

        basketmenu = basketui()
        widget.addWidget(basketmenu)
        widget.setCurrentIndex(widget.currentIndex() + 1)

    def logoff(self):

        zamn = anamenu()
        widget.addWidget(zamn)
        widget.setCurrentIndex(widget.currentIndex() + 1)

    def __init__(self):

        super(user, self).__init__()

        self.setupUi(self)

        self.pushButton_buy.clicked.connect(self.buy)

        self.pushButton_basket.clicked.connect(self.basketuifunc)

        self.pushButton_logoff.clicked.connect(self.logoff)

class signing(QMainWindow, signin.Ui_Widget):

    def amogus(self):
        if self.kayitsifresi.text() == "admin123" and self.kayitmaili.text() == "admin":
            adminmenu = admin()
            widget.addWidget(adminmenu)
            widget.setCurrentIndex(widget.currentIndex() + 1)
        else:
            usermenu = user()
            widget.addWidget(usermenu)
            widget.setCurrentIndex(widget.currentIndex() + 1)


    def __init__(self):

        super(login, self).__init__()

        self.setupUi(self)

        self.kayitol.clicked.connect(self.amogus)
class buy(QMainWindow, BuyMenu.Ui_Widget):

    def __init__(self):
        super(buy, self).__init__()

        self.setupUi(self)





class basketui(QMainWindow, basket.Ui_Widget):
    def __init__(self):

        super(basketui, self).__init__()

        self.basketlistinuiwidget =""

        self.setupUi(self)

app =  QApplication(sys.argv)
main = anamenu()
widget = QStackedWidget()
widget.addWidget((main))
widget.show()
widget.setFixedWidth(400)
widget.setFixedHeight(200)
app.exec()