import axios from "axios";

const baseUrl = "https://localhost:7246/api/"

export default {
    dCandidate(url = baseUrl + 'dcandidate/'){
        return {
            fetchAll: () => axios.get(url),
            fetchById: id => axios.get(url+id),
            create: newRecord => axios.post(url.newRecord),
            update: (id ,updateRecordId) => axios.put(url + id, updateRecordId),
            delete: id => axios.delete(url +  id)
        }
    }
}