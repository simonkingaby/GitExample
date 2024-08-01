# I need to reach the SQL Server to get the data from the database

import pyodbc
import json
from dotenv import load_dotenv
import os

import RoboticsLab.Body.Torso as Torso
import RoboticsLab.Body.Arms as Arms
import RoboticsLab.Body.Legs as Legs

from flask import Flask, jsonify, request

app = Flask(__name__)

# load the environment variables
load_dotenv()

# define the connection string
server = '(local)'
database = 'RoboticsLab'
username = 'body_subsystem'
password = os.getenv('SQL_PASSWORD')
driver = '{ODBC Driver 17 for SQL Server}'
connection_string = f"DRIVER={driver};SERVER={server};DATABASE={database};UID={username};PWD={password}"

# connect to the database
# Comment this out for now
# connection = pyodbc.connect(connection_string)

Torso.Initialize()
Arms.Initialize()
Legs.Initialize()

# call Torso functions
@app.route('/api/torso/bow', methods=['POST'])')
def Bow():
    Torso.Bow()
    
# call Arm functions
@app.route('/api/arms/wigglefingers', methods=['POST'])    
def WiggleFingers():
    Arms.WiggleFingers()
    
# call Leg functions
@app.route('/api/legs/highkick', methods=['POST']))    
def HighKick():
    Legs.HighKick()   

if __name__ == '__main__':
    app.run(debug=True)