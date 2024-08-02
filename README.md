# GitExample

An example of Git Feature Branching, Checkout, Check-in, Merging, and Pull Requests

## Scenario Description

We are a small-to-medium-sized Robotics Startup. Our hardware developers have patented a set of devices for manipulating the robotic limbs and joints. We are the software engineering team and the CIO has hired us to do the development of the application that will control the robot. 

## The Application

The Robot Control Application (RCA) is a multi-platform application that will run on iOS devices, Android devices, and Windows devices. It comprises the following modules:

1) Each team needs to write an Initialize() function that prints "My body part is initialized"
2) And the function for your action.
    a) Torso - Bow()
    b) Arms - WiggleFingers()
    c) Legs - HighKick()
3) Each team member should add several actions to the body part .py file.
4) Then, do
   ```bash
   git add .
   git commit -m "Commit Message"
   git push --set-upstream origin your-branch-name
   ```
   Because we are pushing a new branch that we created on our local machine, we need to add the ```--set-upstream origin your-branch-name``` on the end of the git push.
5) Once you have pushed your branch, you need to go to GitHub and create a Pull Request to move your changes from your branch into the main branch.
6) Sometimes, you will have made conflicting changes to another developer, these will need to be "Resolved" and Committed before you can complete the Pull Request.

### In VS Code 


   
   
