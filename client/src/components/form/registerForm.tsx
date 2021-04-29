import * as React from 'react';
import Form from '../form/form';
import Input from '../input/input';
import {withRouter} from 'react-router-dom';
import {RouteComponentProps} from 'react-router';
import './form.css';

interface IProps extends RouteComponentProps {
  roomId?: number;
}

const RegisterForm: React.FC<IProps> = ({
  roomId
}) => {
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

export default withRouter(RegisterForm);
