import * as React from 'react';
import download from '../../images/download_24px.svg';
import basket from '../../images/delete_24px.svg';
import './story.css';

interface Props {
  storiesNumber: number;
  storyName: string;
  avg: number;
}

const Story: React.FC<Props> = ({
  storiesNumber,
  storyName,
  avg
}) => {
  return (
    <div className="story">
      <div className="story-title">
        <p className="completed_stories">Completed Stories</p>
        <p className="stories-number">{storiesNumber}</p>
        <a className="download" href=""><img src={download} alt="Иконка скачивания"/></a>
      </div>
      <table className="table">
        <tr><td><a href="#ModalWindow" id="ModalWindowClose">{storyName}</a></td><td>14</td><td ><button className="basket" ><img src={basket} alt="Иконка корзины"/></button></td></tr>
        <tr><td>{storyName}</td><td>{avg}</td><td ><button className="basket" ><img src={basket} alt="Иконка корзины"/></button></td></tr>
      </table>
    </div>
  );
};

export default Story;
