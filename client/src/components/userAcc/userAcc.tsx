import * as React from 'react';
import userIcon from '../../images/User_Icon.svg';
import './userAcc.css';

interface Props {
    userName?: string;
}

const UserAcc: React.FC<Props> = ({
  userName
}) => {
  return (
    <div className="header__user-acc">
      <button className="user-acc_button">
        {userName}
        <img className="acc_logo" src={userIcon} width="48" height="48" alt="Аватарка пользователя"/>
      </button>
    </div>
  );
};

export default UserAcc;
