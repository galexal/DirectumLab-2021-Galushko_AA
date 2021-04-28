import * as React from 'react';
import Form from './form';
import Input from '../input/input';
import './form.css';

interface IProps {
  roomId?: number;
}

const InviteForm: React.FC<IProps> = ({
  roomId
}) => {
  return (
    <Form
      roomId={roomId}
      text="Join the room"
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
    </Form>
  );
}

export default InviteForm;
