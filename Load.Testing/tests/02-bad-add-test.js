import http from "k6/http";
import { check, sleep } from "k6";

const URL = "https://localhost:44301/Calculator";
const X = 10000000;
const Y = 10000000;
const RESULT = 20000000;

export const options = {
  stages: [
    { duration: "5s", target: 20 },
    { duration: "10s", target: 10 },
    { duration: "5s", target: 0 },
  ],
};

export default function () {
  const res = http.get(`${URL}/bad-add?x=${X}&y=${Y}`);
  check(res, { "status was 200": (r) => r.status == 200 });
  check(res, { "expected result correct": (r) => r.body == RESULT });
  sleep(1);
}
