import * as React from 'react';
import Form from './form';
import Input from '../input/input';
import './form.css';

function InviteForm() {
  return (
    <Form
      text="Join the room"
      classNameForm="form"
      classNameHeader="form-header"
      fields = {[
        <Input
          key="userInput"
          type="text"
          classNameLabel="form-input-label"
          classNameField="form-input-field"
          text="User name"
          placeholder="Enter your name"
          required={true}
        />]}/>
  );
}

export default InviteForm;
