import * as React from 'react';
import Form from '../form/form';
import RoomInput from '../roomInput/roomInput';

import UserInput from '../userInput/userInput';
import './registerForm.css';

function RegisterForm() {
  return (
    <Form
      text="Create the room:"
      classNameForm="form"
      classNameHeader="form-header"
      fields = {[<UserInput key="userInput"/>, <RoomInput key="roomInput"/>]}/>
  );
}

export default RegisterForm;
