# I need to reach the SQL Server to get the data from the database

import pyodbc
import json
from dotenv import load_dotenv
import os
import sys

sys.path.append("../RoboticsLab.Body.Arms")
sys.path.append("../RoboticsLab.Body.Legs")
sys.path.append("../RoboticsLab.Body.Torso")

import Torso
import Arms
import Legs 

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
@app.route('/api/torso/bow', methods=['POST'])
def Bow():
    return Torso.Bow()
    
    
# call Arm functions
@app.route('/api/arms/wigglefingers', methods=['POST'])    
def WiggleFingers():
    Arms.WiggleFingers()


# call Leg functions
@app.route('/api/legs/highkick', methods=['POST'])   
def HighKick():
    Legs.HighKick()   


if __name__ == '__main__':
    app.run(debug=True)