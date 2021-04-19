import * as React from 'react';
import Greeting from '../greeting/greeting';
import RegisterButton from '../registerButton/registerButton';
import UserInput from '../userInput/userInput';
import './registerForm.css';

function RegisterForm() {
  return (
    <div className="form">
      <Greeting/>
      <h2 className="form-header">Create the room:</h2>
      <UserInput/>
      <div className="room-name">
        <label htmlFor="roomName">Room name</label>
        <input className="room-name__field" type="text" name="roomName" id="roomName" placeholder="Enter room name" required/>
      </div>
      <RegisterButton/>
    </div>
  );
}

export default RegisterForm;
