import * as React from 'react';
import Form from '../form/form';
import Input from '../input/input';
import './form.css';


function RegisterForm() {
  return (
    <Form
      text="Create the room: "
      classNameForm="form"
      classNameHeader="form-header">        
      <Input
      key="userInput"
      type="text"
      classNameLabel="form-input-label"
      classNameField="form-input-field"
      text="User name"
      placeholder="Enter your name"
      required={true}
      />        
      <Input
      key="roomInput"
      type="text"
      classNameLabel="form-input-label"
      classNameField="form-input-field"
      text="Room name"
      placeholder="Enter room name"
      required={true}
      />
    </Form>)
}

export default RegisterForm;
