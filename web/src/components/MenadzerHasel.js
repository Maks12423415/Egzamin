import Form from 'react-bootstrap/Form';
import Button from 'react-bootstrap/Button';
import { useState } from 'react';
export default function MenadzerHasel() {
    const [generate, setGenerate] = useState(false);
    const [password, setPassword] = useState('');
    const [login, setLogin] = useState('');
    const [url, setUrl] = useState('');
    const handleGenerate = (e) => {
        if(e.target.checked){
            setGenerate(true);
        }else{
            setGenerate(false);
        }
    }

    const handleSubmit = (e) => {
        setLogin(e.target.form[1].value);
        setUrl(e.target.form[0].value);
        setPassword(e.target.form[3].value);
    }
  return (
    <div>
      <h1>Menadżer Haseł - wykonał 00000000000</h1>
      <Form style={{padding: "20px", rowGap: "10px"}}>
        <Form.Group>
            <Form.Label>Adres WWW:</Form.Label>
            <Form.Control  type="text" placeholder='Adres strony WWW'/>
        </Form.Group>
        <Form.Group style={{marginTop: "20px"}}>
            <Form.Label>Login:</Form.Label>
            <Form.Control  type="text" placeholder='Twój login'/>
        </Form.Group>
        <Form.Group style={{marginTop: "20px"}}>
            <Form.Check onChange={handleGenerate} type='checkbox' label="Wygeneruj hasło"/>
            <Form.Label >Hasło:</Form.Label>
            <Form.Control disabled={generate == true} type="password" />
        </Form.Group>
        <Button style={{marginTop: "10px"}} onClick={handleSubmit}>Zapisz</Button>
      </Form>
      <p style={{color: "blue"}}>Adres WWW: {url}</p>
      <p>Login: {login}</p>
      {generate == true ? <p>Wygenerowano hasło automatycznie</p> : <p>Hasło: {password}</p>}
    </div>
  );
}
