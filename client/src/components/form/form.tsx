import React from 'react';
import Greeting from '../greeting/greeting';
import RegisterButton from '../button/registerButton';

interface Props {
  text: string;
  classNameForm: string;
  classNameHeader: string;
}

const Form: React.FC<Props> = ({
  text,
  classNameForm,
  classNameHeader,
  children
}) => {
  return (
    <div className={classNameForm}>
      <Greeting/>
      <h2 className={classNameHeader}>{text}</h2>
      {children}
      <RegisterButton/>
    </div>
  );
};

export default Form;
